namespace Program
{
    class Sim{
        public string? simName;
        public string? zanimanjeClass;

        public Sim(string simName, string zanimanjeClass) {
            this.simName = simName;
            this.zanimanjeClass = zanimanjeClass;
        }

        public void print() {
            Console.WriteLine($"Sim name: {simName}\nZanimanje class: {zanimanjeClass}");
        }
    }
}

