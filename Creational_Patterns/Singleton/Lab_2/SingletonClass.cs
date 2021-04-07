using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Lab_2
{
    public class SingletonClass
    {
        private SingletonClass() { }

        //"SingletonClas tipindeki _singleObject filed'ı içerisine instanceyi zaten uygulama çalışırken atıyoruz.

        private static SingletonClass _singleObject = new SingletonClass();

        //Aşağıdaki üyeye static olduğu için instance çıakrmada erişeceğim eriştiğim her yerde bana SingletonClass.cs sınıfının örneklemini teslim edecek.

        public static SingletonClass Sinif { get => _singleObject; }

        public int Toplam(int s1, int s2) => s1 + s2;
    }
}
