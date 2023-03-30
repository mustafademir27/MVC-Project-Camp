using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ImagesProjectFileManager : IImagesProjectFileService
    {
        IImagesProjectFileDal _imagesprojectfileDal;

        // CONSTRUCTOR
        public ImagesProjectFileManager(IImagesProjectFileDal imagesprojectfileDal)
        {
            _imagesprojectfileDal = imagesprojectfileDal;
        }

        public List<ImagesProjectFile> GetList()
        {
            return _imagesprojectfileDal.List();
        }
    }
}
