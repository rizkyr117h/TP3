using System;

public class DoorMachine
{
    //membuat macam2 state dan aksi yang dilakukan
    public enum State { Terbuka, Terkunci }
    public enum Trigger { BukaPintu, KunciPintu }

    //state saat ini
    public State currentState = State.Terkunci;

    //membuat kelas baru untuk transisi
    public class Transition
    {
        public State prevState, nextState;
        public Trigger trigger;

        public Transition(State prevState, State nextState, Trigger trigger)
        {
            this.prevState = prevState;
            this.nextState = nextState;
            this.trigger = trigger;
        }
    }

    //array dari kelas Transition untuk mengisi semua kemungkinan state dan trigger
    Transition[] doorStates =
    {
            new Transition(State.Terkunci, State.Terbuka, Trigger.BukaPintu),
            new Transition(State.Terbuka, State.Terkunci, Trigger.KunciPintu),
        };

    public State GetNextState(State prev, Trigger trigger)
    {
        State currentState = prev;

        for (int i = 0; i < doorStates.Length; i++)
        {
            if (doorStates[i].prevState == prev && doorStates[i].trigger == trigger)
            {
                currentState = doorStates[i].nextState;
            }
        }

        return currentState;
    }

    public void activeTrigger(Trigger trigger)
    {
        State nextState = GetNextState(currentState, trigger);
        currentState = nextState;

        if (currentState == State.Terkunci)
        {
            Console.WriteLine("Pintu Terkunci");
        }
        else
        {
            Console.WriteLine("Pintu Tidak Terkunci");
        }

    }
}
