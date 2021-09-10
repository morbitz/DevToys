﻿#nullable enable

using DevTools.Core.Threading;
using DevTools.Common;
using System;
using System.Composition;

namespace DevTools.Providers.Impl.Tools.Base64EncoderDecoder
{
    [Export(typeof(IToolProvider))]
    [Name("Base64 Encoder/Decoder")]
    [ProtocolName("base64")]
    [Order(0)]
    internal sealed class Base64EncoderDecoderToolProvider : ToolProviderBase, IToolProvider
    {
        public string DisplayName => LanguageManager.Instance.Base64EncoderDecoder.DisplayName;

        public object IconSource { get; }

        [ImportingConstructor]
        public Base64EncoderDecoderToolProvider(IThread thread)
            : base(thread)
        {
            IconSource = CreatePathIconFromPath(nameof(Base64EncoderDecoderToolProvider));
        }

        public bool CanBeTreatedByTool(string data)
        {
            throw new NotImplementedException();
        }

        public IToolViewModel CreateTool()
        {
            throw new NotImplementedException();
        }
    }
}
