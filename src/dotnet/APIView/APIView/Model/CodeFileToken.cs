﻿namespace APIView
{
    public struct CodeFileToken
    {
        public CodeFileToken(string value, CodeFileTokenKind kind, int? numberOfLinesinLeafSection = null, string externalLinkAddress = "")
        {
            Value = value;
            NavigateToId = null;
            Kind = kind;
            DefinitionId = null;
            CrossLanguageDefId = null;
            NumberOfLinesinLeafSection = numberOfLinesinLeafSection;
            ExternalLinkAddress = externalLinkAddress;
        }

        public string DefinitionId { get; set; }

        public string NavigateToId { get; set; }

        public string Value { get; set; }

        public CodeFileTokenKind Kind { get; set; }

        public string CrossLanguageDefId { get; set; }

        public int? NumberOfLinesinLeafSection { get; set; }

        public string ExternalLinkAddress { get; set; }

        public override string ToString()
        {
            return $"{Value} ({Kind})";
        }
    }
}
