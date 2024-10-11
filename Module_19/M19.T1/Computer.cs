namespace M19.T1;

public class Computer
{
    
    public int Id { get; private set; }
    
    public string Mark { get; init; }
    
    public ProcessorType Processor { get; init; }
    
    public double Frequency { get; init; }
    
    public int Ram { get; init; }
    
    public int VolumeHardDisk { get; init; }
    
    public int VolumeMemoryOfVideoCard { get; init; }
    
    public double Price { get; init; }
    
    public int CountOfComputers { get; init; }
    
    public Computer(int id, string mark, ProcessorType processor, double frequency, int ram, int volumeHardDisk, 
        int volumeMemoryOfVideoCard, double price, int countOfComputers)
    {
        Mark = mark;
        Id = id;
        Processor = processor;
        Frequency = frequency;
        Ram = ram;
        VolumeHardDisk = volumeHardDisk;
        VolumeMemoryOfVideoCard = volumeMemoryOfVideoCard;
        Price = price;
        CountOfComputers = countOfComputers;
    }

    public override string ToString()
    {
        return $"Номер {Id}, марка {Mark}, процессор {Processor}, частота {Frequency}, ОЗУ {Ram}Гб, " +
               $"HDD {VolumeHardDisk}Гб, объем памяти в видеокарте {VolumeMemoryOfVideoCard}Гб, цена {Price}, " +
               $"количество {CountOfComputers} ";
    }
}