namespace Program
{
    class Sim{
        public string? simName;
        public int? simAge;
        public string? zanimanjeClass;

        public Sim(string simName, int simAge, string zanimanjeClass) {
            this.simName = simName;
            this.simAge = simAge;
            this.zanimanjeClass = zanimanjeClass;
        }

        public void print() {
            Console.WriteLine($"Sim name: {simName}\nDobna skupina: {simAge}\nZanimanje class: {zanimanjeClass}");
        }
    }
}

