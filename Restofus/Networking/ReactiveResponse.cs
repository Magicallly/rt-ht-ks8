using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Restofus.Networking
{
    public class ReactiveResponse : ReactiveObject, IDisposable
    {
        int statusCode;
        public int StatusCode
        {
            get => statusCode;
            set => this.RaiseAndSetIfChanged(ref statusCode, value);
        }

        ReactiveHeaderCollection headers;
        public ReactiveHeaderCollection Headers
        {
            get => headers;
            set => this.RaiseAndSetIfChanged(ref headers, value);
        }

        ReactiveResponseContent content;
        public ReactiveResponseContent Content
        {
            get => content;
            set => this.RaiseAndSetIfChanged(ref content, value);
        }

        public void Dispose()
        {
            content?.Dispose();
        }
    }
}
