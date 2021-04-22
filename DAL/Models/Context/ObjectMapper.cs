using AutoMapper;
using DAL.Dto.File;
using DAL.Dto.Folder;

namespace DAL.Models.Context
{
    public class ObjectMapper: Profile
    {
        public ObjectMapper()
        {
            CreateMap<FileDto, File>();
            CreateMap<File, FileDto>();
            CreateMap<FolderDto, Folder>();
            CreateMap<Folder, FolderDto>();
        }
    }
}
