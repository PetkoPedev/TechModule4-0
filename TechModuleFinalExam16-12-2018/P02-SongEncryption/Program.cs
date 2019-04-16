using System;
using System.Text;
using System.Text.RegularExpressions;

namespace P02_SongEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            while ((input = Console.ReadLine()).ToLower() != "end")
            {

                string[] inputArray = input.Split(":");

                string artistPattern = @"^[A-Z][a-z\s']+$";
                string songPattern = @"^[A-Z\s]+$";

                string artist = inputArray[0];
                string song = inputArray[1];

                var validArtist = Regex.Match(artist, artistPattern);
                var validSong = Regex.Match(song, songPattern);

                if (validArtist.Success && validSong.Success)
                {
                    StringBuilder encryptedArtist = new StringBuilder();
                    StringBuilder encryptedSong = new StringBuilder();

                    int code = artist.Length;

                    for (int i = 0; i < artist.Length; i++)
                    {
                        int encryptedLetter = 0;
                        if (char.IsUpper(artist[i]) && artist[i] + code > 90)
                        {
                            encryptedLetter = artist[i] + code - 26;
                            encryptedArtist.Append((char)encryptedLetter);
                        }
                        else if (char.IsLower(artist[i]) && artist[i] + code > 122)
                        {
                            encryptedLetter = artist[i] + code - 26;
                            encryptedArtist.Append((char)encryptedLetter);
                        }
                        else if (artist[i] == ' ')
                        {
                            encryptedArtist.Append(' ');
                        }
                        else if (artist[i] == '\'')
                        {
                            encryptedArtist.Append('\'');
                        }
                        else
                        {
                            encryptedArtist.Append((char)(artist[i] + code));
                        }
                    }

                    for (int i = 0; i < song.Length; i++)
                    {
                        int encryptedLetter = 0;
                        if (song[i] + code > 90)
                        {
                            encryptedLetter = song[i] + code - 26;
                            encryptedSong.Append((char)encryptedLetter);
                        }
                        else if (song[i] == ' ')
                        {
                            encryptedSong.Append(' ');
                        }
                        else if (song[i] == '\'')
                        {
                            encryptedSong.Append('\'');
                        }
                        else
                        {
                            encryptedSong.Append((char)(song[i] + code));
                        }
                    }

                    Console.WriteLine($"Successful encryption: {encryptedArtist}@{encryptedSong}");
                }

                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
