using System;


class Date
{
    private int d;
    private int m;
    private int y;

    public int Day
    {

        get { return d; }

        set
        {
            if (value > 31 || value < 1)
            {

                Console.WriteLine("Invalid day");
            }

            d = value;
        }
    }

    public int Month
    {

        get { return m; }

        set
        {
            if (value > 12 || value < 1)
            {

                Console.WriteLine("Invalid month");
            }

            m = value;
        }
    }

    public int Year
    {

        get { return y; }

        set
        {
            if (Convert.ToString(value).Length != 4)
            {

                Console.WriteLine("Year must be 4 digits");
            }

            y = value;
        }
    }

    public Date()
    {
        m = 1;
        d = 1;
        y = 2000;
    }

    public Date(int m, int d, int y)
    {
        Month = m;
        Day = d;
        Year = y;
    }

    public string DisplayUSFormat()
    {

        if (Month <= 12 && Month >= 1)
        {

            if (Day <= 31 && Day >= 1)
            {

                if (Convert.ToString(Year).Length == 4)
                {

                    return Month.ToString("D2") + "/" + Day.ToString("D2") + "/" + Year;
                }
            }
        }
        return "Invalid date";
    }

    public static bool operator ==(Date a, Date b)
    {
        if (a.Month > 12 && a.Month < 1 || b.Month > 12 && b.Month < 1)
        {
            return false;
        }
        if (a.Day > 31 && a.Day < 1 || b.Day > 31 && b.Day < 1)
        {
            return false;
        }
        if (Convert.ToString(a.Year).Length != 4 || Convert.ToString(b.Year).Length != 4)
        {
            return false;
        }
        return a.Day + a.Month + a.Year == b.Day + b.Month + b.Year;
    }
    public static bool operator !=(Date a, Date b)
    {
        if (a.Month > 12 && a.Month < 1 || b.Month > 12 && b.Month < 1)
        {
            return false;
        }
        if (a.Day > 31 && a.Day < 1 || b.Day > 31 && b.Day < 1)
        {
            return false;
        }
        if (Convert.ToString(a.Year).Length != 4 || Convert.ToString(b.Year).Length != 4)
        {
            return false;
        }
        return a.Day + a.Month + a.Year != b.Day + b.Month + b.Year;
    }
    public static bool operator <(Date a, Date b)
    {
        if (a.Month > 12 && a.Month < 1 || b.Month > 12 && b.Month < 1)
        {
            return false;
        }
        if (a.Day > 31 && a.Day < 1 || b.Day > 31 && b.Day < 1)
        {
            return false;
        }
        if (Convert.ToString(a.Year).Length != 4 || Convert.ToString(b.Year).Length != 4)
        {
            return false;
        }
        return a.Day + a.Month + a.Year < b.Day + b.Month + b.Year;
    }
    public static bool operator <=(Date a, Date b)
    {
        if (a.Month > 12 && a.Month < 1 || b.Month > 12 && b.Month < 1)
        {
            return false;
        }
        if (a.Day > 31 && a.Day < 1 || b.Day > 31 && b.Day < 1)
        {
            return false;
        }
        if (Convert.ToString(a.Year).Length != 4 || Convert.ToString(b.Year).Length != 4)
        {
            return false;
        }
        if (a.Year <= b.Year && a.Month <= b.Month && a.Day <= b.Day)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool operator >(Date a, Date b)
    {
        if (a.Month > 12 && a.Month < 1 || b.Month > 12 && b.Month < 1)
        {
            return false;
        }
        if (a.Day > 31 && a.Day < 1 || b.Day > 31 && b.Day < 1)
        {
            return false;
        }
        if (Convert.ToString(a.Year).Length != 4 || Convert.ToString(b.Year).Length != 4)
        {
            return false;
        }
        return a.Day + a.Month + a.Year > b.Day + b.Month + b.Year;
    }
    public static bool operator >=(Date a, Date b)
    {
        if (a.Month > 12 && a.Month < 1 || b.Month > 12 && b.Month < 1)
        {
            return false;
        }
        if (a.Day > 31 && a.Day < 1 || b.Day > 31 && b.Day < 1)
        {
            return false;
        }
        if (Convert.ToString(a.Year).Length != 4 || Convert.ToString(b.Year).Length != 4)
        {
            return false;
        }
        if (a.Year >= b.Year && a.Month >= b.Month && a.Day >= b.Day)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override bool Equals(object obj)
    {
        return obj is Date date &&
               d == date.d &&
               m == date.m &&
               y == date.y &&
               Day == date.Day &&
               Month == date.Month &&
               Year == date.Year;
    }

    public override int GetHashCode()
    {
        return 1;
    }
}

class Reservation
{
    Date resDate = new Date();

    private string name;
    private string time;
    private int numberOfparty;
    private string date;

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
        }
    }
    public string Time
    {
        get
        {
            return this.time;
        }
        set
        {
            this.time = value;
        }
    }
    public string Date
    {
        get { return resDate.DisplayUSFormat(); }
        set
        {
            string[] temp = value.Split('/');
            resDate.Month = Convert.ToInt32(temp[0]);
            resDate.Day = Convert.ToInt32(temp[1]);
            resDate.Year = Convert.ToInt32(temp[2]);

            date = value;
        }
    }

    public Reservation()
    {
        this.name = "Nathan Lewis";
        this.date = "11/28/2021";
        this.time = "12:00";
        this.numberOfparty = 5;
    }

    public Reservation(string name, string date, string time)
    {
        this.name = name;
        this.date = date;
        this.time = time;

        string[] temp = this.date.Split('/');
        resDate.Month = Convert.ToInt32(temp[0]);
        resDate.Day = Convert.ToInt32(temp[1]);
        resDate.Year = Convert.ToInt32(temp[2]);
    }

    public virtual string Display()
    {
        return "Reservation name: " + this.name + ", Date: " + this.date + 
            ", Time: " + this.time;
    }

    public static bool operator ==(Reservation a, Reservation b)
    {
        if (a.resDate == b.resDate && a.time == b.time && a.name == b.name && a.numberOfparty == b.numberOfparty)
        {
            return true;
        }
        return false;
    }

    public static bool operator !=(Reservation a, Reservation b)
    {
        if (a.resDate != b.resDate || a.time != b.time || a.name != b.name || a.numberOfparty != b.numberOfparty)
        {
            return true;
        }
        return false;
    }

    public static bool operator >(Reservation a, Reservation b)
    {
        if (a.resDate > b.resDate)
        {
            return true;
        }
        else if (a.resDate == b.resDate)
        {
            int hourA, minuteA, hourB, minuteB;
            string[] temp = a.time.Split(':');
            hourA = Convert.ToInt32(temp[0]); minuteA = Convert.ToInt32(temp[1]);
            temp = b.time.Split(':');
            hourB = Convert.ToInt32(temp[0]); minuteB = Convert.ToInt32(temp[1]);

            if (hourA > hourB)
            {
                return true;
            }
            else if (hourA == hourB && minuteA > minuteB)
            {
                return true;
            }
        }
        return false;
    }

    public static bool operator <(Reservation a, Reservation b)
    {
        if (a.resDate < b.resDate)
        {
            return true;
        }
        else if (a.resDate == b.resDate)
        {
            int hourA, minuteA, hourB, minuteB;
            string[] temp = a.time.Split(':');
            hourA = Convert.ToInt32(temp[0]); minuteA = Convert.ToInt32(temp[1]);
            temp = b.time.Split(':');
            hourB = Convert.ToInt32(temp[0]); minuteB = Convert.ToInt32(temp[1]);

            if (hourA < hourB)
            {
                return true;
            }
            else if (hourA == hourB && minuteA < minuteB)
            {
                return true;
            }
        }
        return false;
    }

    public static bool operator >=(Reservation a, Reservation b)
    {
        if (a.resDate > b.resDate)
        {
            return true;
        }
        else if (a.resDate == b.resDate)
        {
            int hourA, minuteA, hourB, minuteB;
            string[] temp = a.time.Split(':');
            hourA = Convert.ToInt32(temp[0]); minuteA = Convert.ToInt32(temp[1]);
            temp = b.time.Split(':');
            hourB = Convert.ToInt32(temp[0]); minuteB = Convert.ToInt32(temp[1]);

            if (hourA > hourB)
            {
                return true;
            }
            else if (hourA == hourB && minuteA >= minuteB)
            {
                return true;
            }
        }
        return false;
    }

    public static bool operator <=(Reservation a, Reservation b)
    {
        if (a.resDate < b.resDate)
        {
            return true;
        }
        else if (a.resDate == b.resDate)
        {
            int hourA, minuteA, hourB, minuteB;
            string[] temp = a.time.Split(':');
            hourA = Convert.ToInt32(temp[0]); minuteA = Convert.ToInt32(temp[1]);
            temp = b.time.Split(':');
            hourB = Convert.ToInt32(temp[0]); minuteB = Convert.ToInt32(temp[1]);

            if (hourA < hourB)
            {
                return true;
            }
            else if (hourA == hourB && minuteA <= minuteB)
            {
                return true;
            }
        }
        return false;
    }

    public override bool Equals(object obj)
    {
        return obj is Reservation res &&
                name == res.Name &&
                time == res.Time &&
                date == res.Date;
    }

    public override int GetHashCode()
    {
        return 1;
    }
}

class RoomReservation:Reservation
{
    private string endTime;
    private int roomNumber;

    public string EndTime
    {
        get
        {
            return this.endTime;
        }
        set
        {
            this.endTime = value;
        }
    }
    public int RoomNumber
    {
        get
        {
            return this.roomNumber;
        }
        set
        {
            this.roomNumber = value;
        }
    }

    public RoomReservation()
    {
        this.Name = "Dr. Arisoa";
        this.Date = "11/29/2021";
        this.Time = "14:00";
        this.endTime = "15:00";
        this.roomNumber = 218;
    }

    public RoomReservation(string name, string date, string starttime, string endtime, int room)
    {
        this.Name = name;
        this.Date = date;
        this.Time = starttime;
        this.endTime = endtime;
        this.roomNumber = room;
    }

    public override string Display()
    {
        return "Reservation name: " + this.Name + ", Date: " + this.Date +
            ", Time: " + this.Time + ", End time: " + this.endTime + ", Room: " + this.roomNumber;
    }
}

class TheaterReservation:Reservation
{
    private string playTitle;

    public string PlayTitle
    {
        get
        {
            return playTitle;
        }
        set
        {
            this.playTitle = value;
        }
    }

    public TheaterReservation()
    {
        this.Name = "Cinemark";
        this.Date = "11/29/2021";
        this.Time = "18:00";
        this.playTitle = "The Secret Life of Walter Mitty";
    }

    public TheaterReservation(string theatername, string date, string time, string playtitle)
    {
        this.Name = theatername;
        this.Date = date;
        this.Time = time;
        this.playTitle = playtitle;
    }

    public override string Display()
    {
        return "Reservation name: " + this.Name + ", Date: " + this.Date +
            ", Time: " + this.Time + ", Play title: " + this.playTitle;
    }
}

class CarReservation:Reservation
{
    private string make;
    private string model;
    private int rental;

    public string Make
    {
        get
        {
            return this.make;
        }
        set
        {
            this.make = value;
        }
    }
    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            this.model = value;
        }
    }
    public int Rental
    {
        get
        {
            return this.rental;
        }
        set
        {
            this.rental = value;
        }
    }

    public CarReservation()
    {
        this.Name = "Nathan Lewis";
        this.Date = "11/29/2021";
        this.Time = "17:00";
        this.make = "Honda";
        this.model = "Civis Si";
        this.rental = 0;
    }

    public CarReservation(string name, string date, string time, string make, string model, int rental)
    {
        this.Name = name;
        this.Date = date;
        this.Time = time;
        this.make = make;
        this.model = model;
        this.rental = rental;
    }

    public override string Display()
    {
        return "Reservation name: " + this.Name + ", Date: " + this.Date +
            ", Time: " + this.Time + ", Make: " + this.make + ", Model: " + this.model
            + ", For: " + this.rental + " days";
    }
}