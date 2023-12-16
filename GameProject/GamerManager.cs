using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class GamerManager : IGamerService
    {
        UserValidationManager _userValidationManager;

        public GamerManager(UserValidationManager userValidationManager)
        {
            _userValidationManager = userValidationManager;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationManager.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt oldu.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi.");
        }
    }
}
