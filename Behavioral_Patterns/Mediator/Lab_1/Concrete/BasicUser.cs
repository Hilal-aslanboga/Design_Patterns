using Mediator.Lab_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Lab_1.Concrete
{
    public class BasicUser : IUser
    {
        string _userName;
        IChatMediator _chatMediator;

        public BasicUser(IChatMediator chatMediator, string userName)
        {
            this._userName = userName;
            this._chatMediator = chatMediator;
        }

        public void ReceiveMessage(string message) => Console.WriteLine($"Kullanıcı Tipi: Basic\nKullanıcı Adi: {_userName}\nAlınan Mesaj: {message}");

        public void SendMessage(string message) => _chatMediator.SendMessage(message, this);
    }
}
