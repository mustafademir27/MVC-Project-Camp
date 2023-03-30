using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal : IRepository<Category>
    {

        

        //Aşağıdaki doğru metot değil. Çünkü 100 tablo olsa hepsi için tek tek yazmak zor olur
        ////CRUD
        //// Type Name(); <-- metot yazılımı
        //// Aşağıdaki CRUD operasyınlarını gerçekleştiren metotlar sayesinde Category tablosuna ulaşıp içinde değişiklikler yapabiliriz

        //List<Category> List(); // Tür ve metot ismi aynı olmak zorunda değil
        //void Insert(Category p);
        //void Update(Category p);
        //void Delete(Category p); 


    }
}
