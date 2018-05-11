using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    /// <summary>
    /// Clase de ayuda para hacer deep copy de un objeto
    /// </summary>
    public static class DeepCopyHelper
    {

        public static T DeepCopy<T>(T obj)

        {

            if (!typeof(T).IsSerializable)

            {

                throw new Exception("The source object must be serializable");

            }

            if (Object.ReferenceEquals(obj, null))

            {

                throw new Exception("The source object must not be null");

            }

            T result = default(T);

            using (var memoryStream = new MemoryStream())

            {

                var formatter = new BinaryFormatter();

                formatter.Serialize(memoryStream, obj);

                memoryStream.Seek(0, SeekOrigin.Begin);

                result = (T)formatter.Deserialize(memoryStream);

                memoryStream.Close();

            }

            return result;

        }

    }
}
