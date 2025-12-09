using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal abstract class Document
    {
        protected string author;
        protected string content;

        protected Document(string author, string content)
        {
            this.author = author;
            this.content = content;
        }

        public abstract void Render();
    }

    class ImageDocument : Document
    {
        public ImageDocument(string content, string author) : base(content, author) { }

        public override void Render()
        {
            Console.WriteLine("----------");
            Console.Write("[Изображение]:");
            Console.WriteLine($"Автор: {author}");
            Console.WriteLine($"Разрешение: {content}");
            Console.WriteLine("----------");
        }
    }

    class TextDocument : Document
    {
        public TextDocument(string content, string author) : base(content, author) { }

        public override void Render()
        {
            Console.WriteLine("----------");
            Console.Write("[Текст]:");
            Console.WriteLine($"Автор: {author}");
            Console.WriteLine($"Содержание: {content}");
            Console.WriteLine("----------");
        }
    }
}
