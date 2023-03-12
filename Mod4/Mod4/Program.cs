using System;

class KodePos
{
    private readonly Dictionary<string, string> kodePos = new Dictionary<string, string>
    {
        {"Batununggal", "40266"}, {"Kujangsari", "40287"}, {"Mengger", "40267"}, {"Wates", "40256"},
        {"Cijaura", "40287"}, {"Jatisari", "40286"}, {"Margasari", "40286"}, {"Sekejati", "40286"},
        {"Kebonwaru", "40272"}, {"Maleer", "40274"}, {"Samoja", "40273"}
    };

    public string getKodePos(string kelurahan)
    {
        if (kodePos.TryGetValue(kelurahan, out string kode))
        {
            return kode;
        }
        else
        {
            return "Kode Pos Tidak Ditemukan";
        }
    }
}

public class DoorMachine
{
    private State state;

    public DoorMachine()
    {
        state = State.Locked;
        Console.WriteLine("Pintu terkunci");
    }

    public void Lock()
    {
        if (state == State.Unlocked)
        {
            state = State.Locked;
            Console.WriteLine("Pintu terkunci");
        }
    }

    public void Unlock()
    {
        if (state == State.Locked)
        {
            state = State.Unlocked;
            Console.WriteLine("Pintu tidak terkunci");
        }
    }

    private enum State
    {
        Locked,
        Unlocked
    }
}

class Program
{
    static void Main(string[] args)
    {
        KodePos Pos = new KodePos();

        
        string PosJatisari = Pos.getKodePos("Jatisari");
        Console.WriteLine("Kode Pos Jatisari : " + PosJatisari);

        DoorMachine Door = new DoorMachine();
        Door.Lock();
        Door.Unlock();

        Console.ReadLine();
    }
}