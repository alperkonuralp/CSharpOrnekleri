using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Compression;

namespace DersDemo_cs_Compress
{
    class Program
    {
        static void Main(string[] args)
        {
            // DeflateStream, GZipStream
            // aynı yöntemleri kullanırlar 
            // DeflateStream tek yönlü hareketi destekler. 
            // GZipStream ise Seek kullanımını destekler.

            //VeriyiSikistirma();
            VeriyiAc();
        }

        public static void VeriyiSikistirma()
        {
            string text = @"In Ad Wars, Democrats Shy From Ties to Own Party
By JEFF ZELENY
Published: September 12, 2010

    * comments
    * Sign In to E-Mail
    * Print
    * Single Page
    *
      Reprints

WASHINGTON — Representative Mark Schauer of Michigan does not dwell on the legislation he has voted for during his first term in Congress, which includes the Democratic stimulus plan and health insurance overhaul. But he reminds his constituents what he has fought against, declaring, “I must ask myself 10 times a day, what is Washington thinking?”
Enlarge This Image
Charlie Riedel/Associated Press

In an advertisement, Robin Carnahan, left, a Democratic candidate for the Senate, reminds her Republican opponent, Representative Roy Blunt, “Hey Roy, you’re running against me!”
Multimedia
Graphic
The Congressional Ad Race: Who’s Buying and What’s Been Said?
Blog
The Caucus

The latest on President Obama, his administration and other news from Washington and around the nation. Join the discussion.

    * FiveThirtyEight: Nate Silver's Political Calculus
    * More Politics News

Representative Glenn Nye of Virginia does not mention in his television advertisements that he is a Democrat. But he expresses a deep worry about the national debt, saying, “I stood up to my party leaders and voted no.”

Representative Suzanne M. Kosmas of Florida looks straight into the camera during her latest commercial and declares, “People in this district are mad, and I’m mad, too.”

The advertisements from these three vulnerable Democrats offer a window into the party’s strategy to try to keep control of the House in November at a moment when Republicans and their allies are substantially outspending Democrats and their backers.

Two years after arriving in Washington on a message of hope and change, Democratic candidates are not extolling their party’s accomplishments, but rather distancing themselves from their party’s agenda.

The midterm elections may revolve around a series of big issues, particularly with control of Congress at stake. But a look at the advertising themes and images being employed by Democrats shows all the ways they are trying to personalize their contests and avoid being defined as ideological partners of President Obama’s or as part of the Washington establishment.

In the last six weeks, Republicans have outspent Democrats $20 million to $13 million in television advertising, according to an analysis by The New York Times of 56 of the nation’s most competitive House and Senate races. The Republican advantage includes $9 million in spending from outside groups, compared with $3 million from left-leaning interests.

The disparity in spending, particularly from third-party groups, is the central reason Mr. Obama has agreed to step up his fund-raising efforts for the party in the coming weeks, aides said, and why Speaker Nancy Pelosi is asking leading donors to dig deeper.

The images of Mr. Obama and Ms. Pelosi appear with more frequency than those of any other political figures — but nearly always in Republican advertisements. They have been mentioned so many times that in their advertising some Democrats have started calling out their Republican rivals, including Representative Roy Blunt of Missouri, who is running for the Senate.

“Congressman Roy Blunt seems to think he’s running for the Senate against Barack Obama and Nancy Pelosi,” says Robin Carnahan, the Democratic candidate, standing in the middle of a cow lot on her farm. “Hey Roy, you’re running against me!”

For all the evolutions in technology, with voters able to gather information instantly about candidates from an ever-widening array of sources, television advertising remains the most central ingredient of political races. Many candidates say they are buying more spots than in previous election cycles, hoping to break through to viewers who often tune out the first few times they come across a commercial.

The voices of politicians, along with soothing-sounding narrators talking about the economic stimulus, federal spending and bank bailouts, resonate from television sets throughout the morning, afternoon and evening.

In the last six weeks alone, Republicans broadcast 45,100 commercials and Democrats broadcast 38,400 in the competitive races included in the Times analysis of advertising data collected by the independent Campaign Media Analysis Group.

“The political response to a fragmented media world is to talk louder and longer,” said Evan L. Tracey, president of the group, which monitors political advertising. “This will be the most negative election we’ve probably ever seen, because everyone is trying to tap into voters on an emotional level and no one is looking to entertain right now.”

Many of the most serious and stark messages come in advertisements sponsored by Americans for Prosperity, an advocacy group financed in large part by David Koch, who invests millions of dollars on behalf of conservative causes. The group has focused on a handful of races, spending $1.5 million in seven competitive House seats in the last six weeks, leaving the Democratic candidates under fire at all hours of the day on television.

“To small businesses, Betsy Markey is the same as Nancy Pelosi,” a man says in one of the advertisements, referring to Representative Betsy Markey, Democrat of Colorado. For a one-week stretch in August, the group ran $40,000 worth of commercials every day against her.

In Florida, Marco Rubio, the Republican candidate for the Senate, has spent $1.1 million over the last six weeks on advertisements that are largely positive and biographical, telling the story about how he is a first-generation American of Cuban heritage. Yet in the closing moments of his spots, he says he is worried about his children’s future.

“As the son of exiles, I understand what it means to lose your country,” Mr. Rubio says. “I approve this message because we can’t afford to bankrupt ours.” ";

            File.WriteAllText("c:\\ara\\yazi.txt", text);
            using (FileStream fs = new FileStream(
                "c:\\ara\\yazi.txt.gz",
                FileMode.Create, FileAccess.Write))
            using (GZipStream gz = new GZipStream(
                fs, CompressionMode.Compress))
            using (StreamWriter sw = new StreamWriter(gz))
            {
                sw.Write(text);
            }
        }

        public static void VeriyiAc()
        {
            using (FileStream fs = new FileStream(
                "c:\\ara\\yazi.txt.gz", FileMode.Open,
                FileAccess.Read))
            using (GZipStream gz = new GZipStream(
                fs, CompressionMode.Decompress))
            using (StreamReader sr = new StreamReader(gz))
            {
                string text = sr.ReadToEnd();

                File.WriteAllText("c:\\ara\\yazi2.txt", text);
            }
        }
    }
}
