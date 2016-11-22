using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using School.OnlineBookingSystem.Models;
using System.Runtime.InteropServices.WindowsRuntime;

namespace School.OnlineBookingSystem.Handlers
{
    public static class FileManipulationHandler
    {
        private const string PropertyFile = "property_data.json";

        /// <summary>
        /// Saves properties to json file in the App's local folder
        /// </summary>
        /// <returns></returns>
        /// <param name="properties"></param>
        public static void SavePropertyToJson(ObservableCollection<Property> properties)
        {
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(ObservableCollection<Property>));
            MemoryStream stream = new MemoryStream();
            js.WriteObject(stream, properties);
            var msg = StreamToString(stream);
            try
            {
                var folder = ApplicationData.Current.LocalFolder;
                File.WriteAllText(folder.Path + "\\" + PropertyFile, msg);
                UnicodeEncoding uniEncoding = new UnicodeEncoding();
                using (var stream2 = File.Open(PropertyFile, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    stream2.Write(uniEncoding.GetBytes(msg), 0, msg.Length);
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
        public static async Task SaveBookingToJson(ObservableCollection<Booking> properties)
        {
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(ObservableCollection<Booking>));
            MemoryStream stream = new MemoryStream();
            js.WriteObject(stream, properties);
            var msg = StreamToString(stream);
            try
            {
                var folder = ApplicationData.Current.LocalFolder;
                var file = await folder.CreateFileAsync(PropertyFile, CreationCollisionOption.OpenIfExists);
                await FileIO.WriteTextAsync(file, msg);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                stream.Dispose();
            }
            Debug.WriteLine("Save done");
        }

        public static ObservableCollection<Property> LoadPropertiesFromJson()
        {
            var result = new ObservableCollection<Property>();
            try
            {
                var folder = ApplicationData.Current.LocalFolder;
                var file = File.OpenRead(folder.Path + "\\" + PropertyFile);
                if (file != null)
                {
                    var js = new DataContractJsonSerializer(typeof(ObservableCollection<Property>));
                    result = (ObservableCollection<Property>)js.ReadObject(file);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            Debug.WriteLine("Loading done");
            return result;
        }

        public static async Task<ObservableCollection<Booking>> LoadBookingsFromJson()
        {
            ObservableCollection<Booking> result;
            try
            {
                var folder = ApplicationData.Current.LocalFolder;
                var file = await folder.GetFileAsync(PropertyFile);
                var buffer = await FileIO.ReadBufferAsync(file);
                var stream = new MemoryStream(buffer.ToArray());
                DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(ObservableCollection<Booking>));
                result = (ObservableCollection<Booking>)js.ReadObject(stream);
                stream.Dispose();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            Debug.WriteLine("Loading done");
            return result;
        }

        private static void CleanSavedData()
        {
            SavePropertyToJson(new ObservableCollection<Property>());
        }

        public static string StreamToString(Stream stream)
        {
            stream.Position = 0;
            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
