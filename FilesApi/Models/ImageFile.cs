﻿namespace FilesApi.Models
{
    public class ImageFile
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public int Size { get; set; }
        public byte[] Content { get; set; }
    }
}
