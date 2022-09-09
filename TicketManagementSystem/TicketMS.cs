using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagementSystem
{
    internal class TicketMS
    {
       public string name;
        public string email;
        public string password;



        public TicketMS(string name, string email,string password)
        {
            this.name = name;
            
            this.email = email;

            this.password = password;
        }


        public string Name
        {
            set; 
            get;
        }
        public string Email
        {
            set; 
            get;
        }

        public string Password
        {
            set; 
            get;
        }



    }

    internal abstract class BusA
    {

        string Bname;
        int Bseatnumber;

        public BusA()
        {


        }

        public BusA(string Bname,int Bseatnumber)
        {
            this.Bname = Bname;
            this.Bseatnumber = Bseatnumber;

        }


        public abstract void Bpayment();


    }

    internal class Ena : BusA
    {
        int bnum;


        public Ena() : base()
        {

        }

        public Ena(string Bname,int Bseatnumber,int bnum) : base(Bname,Bseatnumber)

        {
            this.bnum = bnum;
        }
        public override void Bpayment()
        {
 

        }

       /* internal class Program
        {
            static void Main(string[] args)
            {
                BusA s = new Ena("ABC",40,1);
                Ena r = new Ena();
                s.Bpayment();

            }*/
        }


    }











