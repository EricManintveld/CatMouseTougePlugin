using System;
using System.Numerics;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;

namespace TougePlugin.Serialization;
public class Vector2YamlConverter : IYamlTypeConverter
{
    public bool Accepts(Type type) => type == typeof(Vector2);

    public object? ReadYaml(IParser parser, Type type)
    {
        parser.Consume<SequenceStart>();
        var x = float.Parse(((Scalar)parser.Consume<Scalar>()).Value);
        var _y = float.Parse(((Scalar)parser.Consume<Scalar>()).Value);
        var z = float.Parse(((Scalar)parser.Consume<Scalar>()).Value);

        parser.Consume<SequenceEnd>();
        return new Vector2(x, z);
    }

    public void WriteYaml(IEmitter emitter, object? value, Type type)
    {
        throw new NotImplementedException("Serialization is not needed.");
    }
}
