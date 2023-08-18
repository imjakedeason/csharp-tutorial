namespace Program
{
    class Character{
        public string? characterClass;
        public string? characterName;
        public int strength = 10;
        public int magic = 0;

        public Character(string characterClass, string characterName) {
            this.characterClass = characterClass;
            this.characterName = characterName;
        }

        public void print() {
            Console.WriteLine($"Character class: {characterClass}\nCharacter name: {characterName}");
            // mozemo zapisati i ovako
            // Console.WriteLine("Character class: " + characterClass + "\nCharacter name: " + characterName");
        }
    }
}

