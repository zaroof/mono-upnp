// 
// Item.cs
//  
// Author:
//       Scott Peterson <lunchtimemama@gmail.com>
// 
// Copyright (c) 2009 Scott Peterson
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

using Mono.Upnp.Xml;

namespace Mono.Upnp.Dcp.MediaServer1.ContentDirectory1
{
    [XmlType ("item", Schemas.DidlLiteSchema)]
    public class Item : Object
    {
        protected Item ()
        {
        }

        public Item (string id, string parentId, ItemOptions options)
            : base (id, parentId, options)
        {
            RefId = options.RefId;
        }

        protected void CopyToOptions (ItemOptions options)
        {
            base.CopyToOptions (options);

            options.RefId = RefId;
        }

        public new ItemOptions GetOptions ()
        {
            var options = new ItemOptions ();
            CopyToOptions (options);
            return options;
        }
        
        [XmlAttribute ("refID", Schemas.DidlLiteSchema, OmitIfNull = true)]
        public virtual string RefId { get; protected set; }
        
        public bool IsReference { get { return RefId != null; } }
        
        protected override void DeserializeAttribute (XmlDeserializationContext context)
        {
            context.AutoDeserializeAttribute (this);
        }
        
        protected override void Serialize (XmlSerializationContext context)
        {
            AutoSerialize (this, context);
        }
        
        protected override void SerializeMembers (XmlSerializationContext context)
        {
            AutoSerializeMembers (this, context);
        }
    }
}
