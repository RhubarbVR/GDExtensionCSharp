namespace Documentation;

#pragma warning disable CS8618
[XmlRootAttribute("class", IsNullable = false)]
public record Class {
	[XmlAttribute] public string name;
	[XmlAttribute] public string inherits;
	[XmlAttribute] public string version;
	public string brief_description;
	public string description;
	public Link[] tutorials;
	public Method[] methods;
	public Member[] members;
	public Signal[] signals;
	public Constant[] constants;
}

[XmlType("link")]
public record Link {
	[XmlAttribute] public string title;
	[XmlText] public string link;
}

[XmlType("method")]
public record Method {
	[XmlAttribute] public string name;
	[XmlAttribute] public string? qualifiers;
	public Return @return;
	[XmlElement("param")] public Parameter[]? parameters;
	public string description;
}

[XmlType("return")]
public record Return {
	[XmlAttribute] public string type;
}

[XmlType("param")]
public record Parameter {
	[XmlAttribute] public int index;
	[XmlAttribute] public string name;
	[XmlAttribute] public string type;
}

[XmlType("constant")]
public record Constant {
	[XmlAttribute] public string name;
	[XmlAttribute] public int value;
	[XmlAttribute] public string? @enum;
	[XmlText] public string? comment;
}

[XmlType("member")]
public record Member {
	[XmlAttribute] public string name;
	[XmlAttribute] public string type;
	[XmlAttribute] public string setter;
	[XmlAttribute] public string getter;
	[XmlAttribute] public string? @enum;
	[XmlAttribute] public string? @default;
	[XmlText] public string comment;
}

[XmlType("signal")]
public record Signal {
	[XmlAttribute] public string name;
	[XmlArray("param")] public Parameter[] parameters;
	public string description;
}
#pragma warning restore CS8618
