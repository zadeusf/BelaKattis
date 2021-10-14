using System;

public class solution
{
    public static void Main(string[] args)
    {

        //initialize sizes
        const int number = 8;
        const int suit = 4;

        //initialize card/suit arrays
        string[] cards_number = new string[number] { "A", "K", "Q", "J", "T", "9", "8", "7" };
        string[] cards_suit = new string[suit] { "S", "H", "D", "C" };

        //initialize score arrays
        int[] dominant_number = new int[number] { 11, 4, 3, 20, 10, 14, 0, 0 };
        int[] non_dominant_number = new int[number] { 11, 4, 3, 2, 10, 0, 0, 0 };

        //initialize suit
        char dominant_suit = ' ';
        int number_of_hands = 0;

        //wE will use this for the card input, after the user puts in dominant suit and num of hands
        char user_card = ' ';
        char user_suit = ' ';

        int total_points = 0;

        //get input, split it. array spot 0 is hands, array spot 1 is dominant suit

        bool checkinput = false;

        while (checkinput == false)
        {
            Console.WriteLine("Input the amount of hands and specify the suit with a space inbetween ");
            string[] input = Console.ReadLine().ToString().Split();

            //cast the number of hands string to an int
            number_of_hands = int.Parse(input[0]);
            dominant_suit = char.Parse(input[1]);

            if ((number_of_hands > 0) && (dominant_suit == 'H' || dominant_suit == 'D' || dominant_suit == 'C' || dominant_suit == 'S'))
            {
                Console.WriteLine("BREAK CHECK 1");
                checkinput = true;

            }
        }
        //  Console.WriteLine("Number of hands: " + number_of_hands);
        //  Console.WriteLine("Dominant suit: " + dominant_suit);
        //Now that you have these, you can loop through 4 * the number the user input
        for (int i = 0; i < (4 * number_of_hands); i++)
        {
            bool checkinput2 = false;
            string values;
            while (checkinput2 == false)
            {
                Console.WriteLine("Enter a Card Value");
                values = Console.ReadLine();
                user_card = values[0];
                user_suit = values[1];
                if ((user_card == 'A' || user_card == 'K' || user_card == 'Q' || user_card == 'J' || user_card == 'T' || user_card == '9' || user_card == '8' || user_card == '7') && (user_suit == 'H' || user_suit == 'D' || user_suit == 'C' || user_suit == 'S'))
                {
                    Console.WriteLine("BREAK CHECK 2");
                    checkinput2 = true;

                }
            }


            //First we have to determine the array spot/index the user specified card is, so we can get the correct score number;
            //   int card_array_spot = Array.IndexOf(cards_number, user_card);
            int card_array_spot = 0;
            for (int j = 0; j < cards_number.Length; j++)
            {
                if (user_card == char.Parse(cards_number[j]))
                {
                    card_array_spot = j;
                }
            }
            //Console.WriteLine("Value[0] is:"+values[0]);
            //Console.WriteLine("index of card:"+card_array_spot);


            //Now we check to see if the suit is the dominant suit, and get the score from the card index we just found and add it to the total score
            if (user_suit == dominant_suit)
            {
                total_points += dominant_number[card_array_spot];
                Console.WriteLine("Total points: " + total_points);

            }
            else

            {
                //Console.WriteLine("else");
                total_points += non_dominant_number[card_array_spot];
                // Console.WriteLine(total_points);
            }
            Console.WriteLine(total_points);
        }
    }
}


//        string current_card_number = current_card[0].ToString();
// string dominant_string = input[1][0].ToString();
//   _ = current_card_suit[1].ToString();