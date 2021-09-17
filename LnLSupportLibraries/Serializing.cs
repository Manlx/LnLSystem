//Manuel A Nunes 34551875 2021/08/25
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Serializing
{
    public static class Serializer
    {
        //Serialize Data to binary Format and saves it in the proper file path
        public static bool SerializeToBin(object Data, string Path, bool Overwrite = true)
        {
            if (File.Exists(Path) && !Overwrite)
                return false;
            FileStream FileS = new FileStream(Path, FileMode.Create);
            BinaryFormatter BinFormatter = new BinaryFormatter();
            BinFormatter.Serialize(FileS, Data);
            FileS.Close();
            return true;
        }
        //Deserializes the file and returns the data in an object.
        public static bool DeserializeFromBin(string Path, out object Data)
        {
            Data = null;
            if (!File.Exists(Path))
                return false;
            BinaryFormatter BinFormat = new BinaryFormatter();
            FileStream FileS = new FileStream(Path, FileMode.Open);
            Data = BinFormat.Deserialize(FileS);
            FileS.Close();
            return true;
        }
    }
}
