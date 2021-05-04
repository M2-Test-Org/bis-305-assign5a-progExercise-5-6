using Xunit;
using System.IO;
using System;
using System.Text;

public class Assignment2CaseTests
{

    [Fact]
    public void TestAssign5ProgExercise5_6()
    {
        //Sets the Out property to target the TextWriter object. Note that the System.IO.StringWriter is 
        //derived from TextWriter. The TextWriter class is an abstract class. Therefore, you do not 
        //instantiate it in your code.
        //The StreamWriter class derives from TextWriter and provides implementations of the members for 
        //writing to a stream. 
        var output = new StringWriter();
        Console.SetOut(output);
        
        DisplayMultiplicationTable.Main();

        //use a string writer to format the expected outcome
        var expectedOutcome = new StringBuilder();
        expectedOutcome.AppendLine("         1    2    3    4    5    6    7    8    9   10");
        expectedOutcome.AppendLine("____________________________________________________________");
        expectedOutcome.AppendLine("    1    1    2    3    4    5    6    7    8    9   10");
        expectedOutcome.AppendLine("    2    2    4    6    8   10   12   14   16   18   20");
        expectedOutcome.AppendLine("    3    3    6    9   12   15   18   21   24   27   30");
        expectedOutcome.AppendLine("    4    4    8   12   16   20   24   28   32   36   40");
        expectedOutcome.AppendLine("    5    5   10   15   20   25   30   35   40   45   50");
        expectedOutcome.AppendLine("    6    6   12   18   24   30   36   42   48   54   60");
        expectedOutcome.AppendLine("    7    7   14   21   28   35   42   49   56   63   70");
        expectedOutcome.AppendLine("    8    8   16   24   32   40   48   56   64   72   80");
        expectedOutcome.AppendLine("    9    9   18   27   36   45   54   63   72   81   90");
        expectedOutcome.AppendLine("   10   10   20   30   40   50   60   70   80   90  100");

        Assert.Equal(expectedOutcome.ToString(), output.ToString());

        //clean up
        output.Dispose();
    }
}
