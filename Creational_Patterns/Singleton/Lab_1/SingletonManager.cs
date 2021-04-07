using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Lab_1
{
    public class SingletonManager
    {
        private static SingletonManager _singletonManager;

        private SingletonManager() { } //Buradaki amaç bu sınıfın dışarıya erişmesini engelemek

        ////Sınıfa dışarıdna erişmek için constructor, custom method yada property üzerinden erişimi kontrol altına alabilirim.
        //Bu örnekte aşağıda oluşturduğumuz custom method aracılığı ile yapacağız

        public static SingletonManager CreateSingletonObject()
        {
            //Uygulamın herhangi bir yerinde "SinletonManager." diyerek CreateSingeletonObject() methoduna erişebilirim çünkü method static. Bu methodu çağırdığımda yapacağı işlem:

            if (_singletonManager == null) // eğer _singletonManager filed içerisi boş ise 
            {
                _singletonManager = new SingletonManager();  //ihityacım olan nesneye kontrollü bir şekilde erişeceğim
            }
            //_singletonManager nesnesi dolu ise zaten direk bize onu teslim edecek
            return _singletonManager;
        }

        public void CreateLog() => Console.WriteLine("A log was created.");
    }
}
