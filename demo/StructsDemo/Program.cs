
namespace StructsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Car simpleCar = new Car();
            simpleCar.Model = "Type R";

            Car audi = new Car("RS");
            Car alfa = new Car("Alfa Romeo", "145");


        }
    }
    struct Car
    {
        
        public string Make;
        //full property (propfull snippet)         
        public string model;
        public string Model
        {
            get { return model; }
            set { model = value; }

        }
        //struct constructor 
        public Car(string model)
        {
            Make = "Undefined";
            this.model = model;
        }
        //struct overloaded constructor 
        public Car(string make, string model)
        {
            Make = make;
            this.model = model;
        }
    }
}
