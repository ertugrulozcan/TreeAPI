using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeAPI
{
    public abstract class Test
    {
        static char[] alphabet = { 'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'ğ', 'h', 'ı', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z' };

        public static string Run()
        {
            Tree<string> libraryTree = new Tree<string>("Music Library");
            
            var ArtistsNode = new Node<string>("Artists");
            foreach (char letter in alphabet)
                ArtistsNode.Add(letter.ToString());
            libraryTree.Root.Add(ArtistsNode);

            var AlbumsNode = new Node<string>("Albums");
            foreach (char letter in alphabet)
                AlbumsNode.Add(letter.ToString());
            libraryTree.Root.Add(AlbumsNode);

            string result = libraryTree.Print();
            return result;
        }
    }
}
