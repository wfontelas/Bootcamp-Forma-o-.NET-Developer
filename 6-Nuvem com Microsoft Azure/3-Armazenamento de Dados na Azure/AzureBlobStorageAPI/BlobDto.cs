using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureBlobStorageAPI
{
    public class BlobDto //Data transfer object
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Uri { get; set; }
    }
}