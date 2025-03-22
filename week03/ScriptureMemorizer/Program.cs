using System.IO;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        Reference oldT = new Reference("2 Kings", 2, 23, 24);
        Scripture oldTestament = new Scripture(oldT, "And he went up from thence unto Beth-el: and as he was going up by the way, there came forth little children out of the city, and mocked him, and said unto him, Go up, thou bald head; go up, thou bald head. And he turned back, and looked on them, and cursed them in the name of the Lord. And there came forth two she bears out of the wood, and tare forty and two children of them.");
        Reference newT = new Reference("Matthew", 3, 15, 17);
        Scripture newTestament = new Scripture(newT, "And Jesus answering said unto him, Suffer it to be so now: for thus it becometh us to fulfil all righteousness. Then he suffered him. And Jesus, when he was baptized, went up straightway out of the water: and, lo, the heavens were opened unto him, and he saw the Spirit of God descending like a dove, and lighting upon him: And lo a voice from heaven, saying, This is my beloved Son, in whom I am well pleased.");
        Reference bom = new Reference("3 Nephi", 5, 13);
        Scripture bookOfMormon = new Scripture(bom, "Behold, I am a disciple of Jesus Christ, the Son of God. I have been called of him to declare his word among his people, that they might have everlasting life");
    
        Console.WriteLine("Where would you like to memorize a verse from?");
        Console.WriteLine("1. The Old Testament(2 Kings 2: 23-24)");
        Console.WriteLine("2. The New Testament(Matthew 3: 15-17)");
        Console.WriteLine("3. The Book of Mormon(3 Nephi 5: 16)");
        string choiceStr = Console.ReadLine();
        int choice = int.Parse(choiceStr);

        Random randNum = new Random();

        switch (choice){
            case 1:
                string read;
                Console.WriteLine(oldTestament.GetDisplayText());
                do{
                    Console.Clear();
                    int num = randNum.Next(1, 5);
                    oldTestament.HideRandomWords(num);

                    Console.WriteLine(oldTestament.GetDisplayText());
                    read = Console.ReadLine();
                } while(read != "quit" || oldTestament.IsCompletelyHidden() == true);
            break;
            case 2:
                Console.WriteLine(newTestament.GetDisplayText());
                do{
                    Console.Clear();
                    int num = randNum.Next(1, 5);
                    newTestament.HideRandomWords(num);

                    Console.WriteLine(newTestament.GetDisplayText());
                    read = Console.ReadLine();
                } while(read != "quit" || newTestament.IsCompletelyHidden() == true);
            break;
            case 3:
                Console.WriteLine(bookOfMormon.GetDisplayText());
                do{
                    Console.Clear();
                    int num = randNum.Next(1, 5);
                    bookOfMormon.HideRandomWords(num);

                    Console.WriteLine(bookOfMormon.GetDisplayText());
                    read = Console.ReadLine();
                } while(read != "quit" || bookOfMormon.IsCompletelyHidden() == true);
            break;
        }

    }
}