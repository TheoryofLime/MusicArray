using System;

namespace movies
{
    class Program
    {
        enum Genre
        {
            Genre1,
            Genre2,
            Genre3,
            Genre4,
            Genre5
        }

        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre varGenre;

            /*
            public Music(string title, string artist, string album, string length, Genre vargenre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                varGenre = vargenre;
            }
            */

            public void setTitle(string title)
            {
                Title = title;
            }
            public void setArtist(string artist)
            {
                Artist = artist;
            }
            public void setAlbum(string album)
            {
                Album = album;
            }
            public void setLength(string length)
            {
                Length = length;
            }
            public void setGenre(Genre genre)
            {
                varGenre = genre;
            }

            public string displayInfo()
            {
                return "Title: " + Title + "\nArtist: " + Artist + "\nAlbum: " + Album + "\nLength (Seconds): " + Length + "\nGenre: " + varGenre;
            }
        }
        static void Main(string[] args)
        {
            Genre tempGenre;
            char chr;

            Console.WriteLine("How many songs will you enter?");
            int musicsize = int.Parse(Console.ReadLine());
            Music[] musiccollection = new Music[musicsize];

            try
            {
                for (int i = 0; i < musicsize; i++)
                {
                    Console.WriteLine("What is the name of the song?");
                    musiccollection[i].setTitle(Console.ReadLine());
                    Console.WriteLine("Who is the artist?");
                    musiccollection[i].setArtist(Console.ReadLine());
                    Console.WriteLine("What is the album?");
                    musiccollection[i].setAlbum(Console.ReadLine());
                    Console.WriteLine("What is the length? (Seconds)");
                    musiccollection[i].setLength(Console.ReadLine());
                    Console.WriteLine("What is the genre?");
                    Console.WriteLine("[ 1 ] : Genre1 | [ 2 ] : Genre2 | [ 3 ] : Genre3 | [ 4 ] : Genre4 | [ 5 ] : Genre5");
                    tempGenre = Genre.Genre1;
                    chr = char.Parse(Console.ReadLine());
                    switch (chr)
                    {
                        case '1':
                            tempGenre = Genre.Genre1;
                            break;
                        case '2':
                            tempGenre = Genre.Genre2;
                            break;
                        case '3':
                            tempGenre = Genre.Genre3;
                            break;
                        case '4':
                            tempGenre = Genre.Genre4;
                            break;
                        case '5':
                            tempGenre = Genre.Genre5;
                            break;
                    }
                    musiccollection[i].setGenre(tempGenre);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                for (int j = 0; j < musiccollection.Length; j++)
                {
                    Console.WriteLine($"{musiccollection[j].displayInfo()}");
                }
            }
        }
    }
}
