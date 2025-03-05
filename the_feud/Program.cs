using IField;
using McDroid;
using IFieldPig = IField.Pig;
using McDroidPig = McDroid.Pig;

IFieldPig IFieldPig = new IFieldPig();
McDroidPig McDroid = new McDroidPig();
Cow McDroidCow = new Cow();
Sheep IfFieldSheep = new Sheep();


namespace IField
{
    public class Sheep { };

    public class Pig { };
}

namespace McDroid
{
    public class Cow { };
    public class Pig { };
}

