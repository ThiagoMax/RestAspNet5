using Microsoft.AspNetCore.Http;
using RWANU.Data.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RWANU.Business
{
    public interface IFileBusiness
    {
        public byte[] GetFile(string name);
        public Task<FileDetailVO> SaveFileToDisk(IFormFile file);
        public Task<List<FileDetailVO>> SaveMultFilesToDisk(IList<IFormFile> file);
    }
}
