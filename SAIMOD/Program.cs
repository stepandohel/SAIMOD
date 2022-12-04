using SAIMOD;

int train1;
int train2;
int train21;
int train22;

Random rand = new Random();

var station = new Station();
var station4 = new Station4();

var N = 0;
var list = new List<double>();



//var array = new List<int>();
//for (int i = 0; i < 20 * 24; i++)
//{
//    var num1 = rand.Next(10, 30);
//    var num2 = rand.Next(10, 20);
//    var num3 = 60 - num2 - num1;
//    array.Add(num1);
//    array.Add(num2);
//    array.Add(num3);
//}
//var count = 0;

var Okup = false;
var days = 0;
var time = 0;

while (!Okup)
{
    for (int j = 0; j <= 23; j++)
    {
        train1 = rand.Next(0, 59);
        train2 = rand.Next(0, 59);

        //train21 = rand.Next(1, 60);
        //train22 = rand.Next(1, 60);


        for (int i = 0; i <= 59; i++)
        {
            if (train1 == i)
            {
                time = Convert.ToInt32(Math.Ceiling(Math.Log(rand.NextDouble()) * (-20.0)));
                station.AddTrain(new Train(station, time));
                station4.AddTrain(new Train(station4, time));
            }
            if (train2 == i)
            {
                time = Convert.ToInt32(Math.Ceiling(Math.Log(rand.NextDouble()) * (-20.0)));
                station.AddTrain(new Train(station, time));
                station4.AddTrain(new Train(station4, time));
            }



            //if (train21 == i)
            //{
            //    station4.AddTrain(new Train(station4, Convert.ToInt32(Math.Ceiling(Math.Log(rand.NextDouble()) * (-20.0)))));
            //}
            //if (train22 == i)
            //{
            //    station4.AddTrain(new Train(station4, Convert.ToInt32(Math.Ceiling(Math.Log(rand.NextDouble()) * (-20.0)))));
            //}

            //var buf = (Math.Log(rand.NextDouble()) * (-20.0));

            //list.Add(buf);


            station.NextMin();
            station4.NextMin();
        }
    }
    days++;
    if (station.SummaryFine > station4.SummaryFine + 1000000)
        Okup = true;
}
//var a = 0.0;

//foreach (var item in list)
//{
//    a += item;
//}
//a = a / list.Count;
Console.WriteLine(days);