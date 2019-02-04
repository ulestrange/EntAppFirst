using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntApp1.Models
{

    /* This class holds the name of a province and whether it has been chosen
     */
    public class ProvincesSelected
    {

        public string ProvinceName { get; set; }
        public bool IsChosen { get; set; }

        public ProvincesSelected(string provinceName, bool isChosen)
        {
            ProvinceName = provinceName;
            IsChosen = isChosen;
        }

        public ProvincesSelected()
        {
            ProvinceName = "";
            IsChosen = false;
        }


    }
}

