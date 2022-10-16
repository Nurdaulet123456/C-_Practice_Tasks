using System;

namespace HomeWork_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Program");
            Canon c = new Canon("Canon", 2015);

            Console.WriteLine(c.InfoAboutCamera());
        }
    }

    class Camera {
    string name;
    int age;
    int count = 0;
        public Camera() {
        }

        public Camera(
            string name,
            int age
        ) {
            this.name = name;
            this.age = age;
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

        public virtual string InfoAboutCamera() {
            return $"Camera Name: {this.name} \n Camera Age: {this.age}";
        }

        public static int buyCamera(int count) {
            int buy = 0;
            for (int i = 0; i < count; i++) {
                 buy += count;
            }

            return buy;
        }
    }

    class Canon : Camera {
        string name;
        int age;
        int count;

        public Canon() {
        } 

        string Name {
            get; set;
        }

        int Age {
            get; set;
        }

        public Canon(string name, int age) : base(name, age) {
            Name = name;
            Age = age;
        }

        public override string InfoAboutCamera() {
            return $"Camera Name: {this.name}\nCamera Age: {this.age}";
        }
    }

    class Nicon : Camera {
    string name;
    int age;
    int count;

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

    public Nicon(string name, int age) : base(name, age) {
        Name = name;
        Age = age;
    }

    public override  string InfoAboutCamera() {
        return $"Camera Name: {this.name} \n Camera Age: {this.age}";
    }
}
}
