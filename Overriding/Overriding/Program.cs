namespace Overriding
{
    //Plane class inheriting from Airport class
    public class Plane : Airport
    {
        public override void Takeoff()
        {
            //Takeoff from runway
        }
    }

    public class Airport
    {
        public virtual void Takeoff()
        {
            //Takeoff from terminal
            //but planes dont takeoff from terminal...they take off from runway
        }
    }

    public class Main
    {
        public void DoStuff()
        {
            Plane myPlane = new Plane();
            myPlane.Takeoff();//this will use the overriden Airport Takeoff() method 
                              //and will use the Plane Takeoff() method
        }
    }
}