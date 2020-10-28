using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceMtk_P1_20180140022
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMatematika
    {


        // TODO: Add your service operations here

        [OperationContract]
        /* output->*/
        int Tambah(int a, int b); //method
        [OperationContract]
        int Kurang(int a, int b); //input
        [OperationContract]
        int Kali(int a, int b);
        [OperationContract]
        int Bagi(int a, int b);
        [OperationContract]
        Koordinat TKoordinat(Koordinat a, Koordinat b); //object dari class

    }
    
    public class Koordinat
    {
        private int _x, _y; //atribut
        public int X //properties
        {
            get { return _x; }
            set { _x = value; }
        }
        public int Y //properties
        {
            get { return _y; }
            set { _y = value; }
        }
    }

}
