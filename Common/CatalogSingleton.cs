using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace School.OnlineBookingSystem.Common
{
    public class Catalog<T>
    {
        protected string FilePath { get; set; }
        public ObservableCollection<T> Collection { get; set; }
        private static Catalog<T> _instance;

        public static Catalog<T> Instance
        {
            get
            {
                if (_instance != null)
                {
                    return _instance;
                }
                _instance = new Catalog<T>();
                return _instance;
            }

        }

        internal Catalog()
        {

        }

        public async Task SaveCollection()
        {
            var js = new DataContractJsonSerializer(typeof(ObservableCollection<T>));
            var stream = new MemoryStream();
            js.WriteObject(stream, Collection);
            var msg = StreamToString(stream);
            try
            {
                try
                {
                    await ApplicationData.Current.LocalFolder.CreateFolderAsync("data");
                }
                catch (Exception e)
                {
                    Debug.WriteLine("Folder already exists");
                }
                var folder = await ApplicationData.Current.LocalFolder.GetFolderAsync("data");
                if (folder != null)
                {
                    File.WriteAllText(folder.Path + "\\" + FilePath, msg);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                stream.Dispose();
            }
            Debug.WriteLine("Save done");
        }

        public async Task<ObservableCollection<T>> LoadCollection()
        {
            var result = new ObservableCollection<T>();
            try
            {
                var folder = await ApplicationData.Current.LocalFolder.GetFolderAsync("data");
                var file = File.OpenRead(folder.Path + "\\" + FilePath);
                if (file != null)
                {
                    var js = new DataContractJsonSerializer(typeof(ObservableCollection<T>));
                    result = (ObservableCollection<T>)js.ReadObject(file);
                }
            }
            catch (Exception e)
            {
               Debug.WriteLine(e.Message);
            }
            Debug.WriteLine("Loading done", FilePath);
            Collection = result;
            return result;
        }

        private static string StreamToString(Stream stream)
        {
            stream.Position = 0;
            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
