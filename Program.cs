using System;

// Абстрактный создатель Creator
public abstract class DocumentCreator
{
    public abstract Document CreateDocument();

    public void ProcessDocument()
    {
        Document doc = CreateDocument();
        doc.Open();
        doc.Save();
    }
}

// Конктреные создатели ConcreteCreator для разных документов
public class PdfDocumentCreator : DocumentCreator
{
    public override Document CreateDocument() => new PdfDocument();
}

public class WordDocumentCreator : DocumentCreator
{
    public override Document CreateDocument() => new WordDocument();
}

// Абстрактный продукт Product
public abstract class Document
{
    public abstract void Open();
    public abstract void Save();
}

// Конкретные абстрактные продукты ConcreteProduct
public class PdfDocument : Document
{
    public override void Open() => Console.WriteLine("Открыт PDF-документ");
    public override void Save() => Console.WriteLine("PDF сохранен");
}

public class WordDocument : Document
{
    public override void Open() => Console.WriteLine("Открыт Word-документ");
    public override void Save() => Console.WriteLine("DOCX сохранен");
}

class Program
{
    static void Main()
    {
        DocumentCreator creator = new PdfDocumentCreator();
        creator.ProcessDocument();

        creator = new WordDocumentCreator();
        creator.ProcessDocument();
    }
}