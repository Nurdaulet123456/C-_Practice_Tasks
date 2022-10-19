using System;

namespace HomeWork_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Program");
            Canon c = new Canon("Canon", 2015);
            Nicon n = new Camera("Nicon", 2008);

            Console.WriteLine(c.InfoAboutCamera());
            Console.WriteLine(c.buyCamera(3));

            Console.WriteLine(n.InfoAboutCamera());
            Console.WriteLine(n.buyCamera(3));

            Console.ReadKey();
        }
    }

    class Camera {
    public readonly string name;
    public int age;
    public int count = 0;
        public Camera() {
        }

        public Camera(
            string name,
            int age,
            int count
        ) {
            this.name = name;
            this.age = age;
            this.count = count;
        }

        public string Name {
            get {
                return this.name;
            }

            set {
                this.name = value;
            }
        }

        public int Age {
            get {
                return this.age;
            }

            set {
                this.age = value;
            }
        }

        public int Count {
            get {
                return this.count;
            }

            set {
                this.count = value;
            }
        }

        public virtual string InfoAboutCamera() {
            return $"Camera Name: {this.name} \n Camera Age: {this.age}";
        }

        public virtual int buyCamera(int count) {
            int buy = 0;
            for (int i = 0; i < count; i++) {
                 buy += count;
            }

            return buy;
        }
    }

    class Canon : Camera {
        public readonly string name;
        public int age;
        public int count;

        public Canon() {
        } 

        string Name {
            get; set;
        }

        int Age {
            get; set;
        }

        public Canon(string name, int age, int count) : base(name, age, count) {
            Name = name;
            Age = age;
        }

        public override int buyCamera(int count) {
            int buy = 0;
            for (int i = 0; i < count; i++) {
                 buy += count;
            }

            return buy;
        }

        public override string InfoAboutCamera() {
            return $"Camera Name: {this.name}\nCamera Age: {this.age}\nCamera Count: {this.count}";
        }
    }

    class Nicon : Camera {
   public readonly string name;
   public int age;
   public int count;

    public Nicon() {
        this.name = "";
        this.age = 0;
        this.count = 0;
    } 

    string Name {
        get; set;
    }

    int Age {
        get; set;
    }

    int Count {
        get; set;
    }

    public Nicon(string name, int age, int count) : base(name, age, count) {
        Name = name;
        Age = age;
        Count = count;
    }

    public override int buyCamera(int count) {
            int buy = 0;
            for (int i = 0; i < count; i++) {
                 buy += count;
            }

            return buy;
    }

    public override  string InfoAboutCamera() {
        return $"Camera Name: {this.name} \n Camera Age: {this.age}";
    }
}
}
