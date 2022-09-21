namespace L06Inheritance.Examples.Circuits;

public abstract class CompoundCircuit : Circuit
{
    public Circuit C1 { get; }
    public Circuit C2 { get; }

    public CompoundCircuit(Circuit c1, Circuit c2)
    {
        C1 = c1;
        C2 = c2;
    }
}