/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the clouddirectory-2016-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudDirectory.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CloudDirectory.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TypedLinkSpecifier Marshaller
    /// </summary>       
    public class TypedLinkSpecifierMarshaller : IRequestMarshaller<TypedLinkSpecifier, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TypedLinkSpecifier requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetIdentityAttributeValues())
            {
                context.Writer.WritePropertyName("IdentityAttributeValues");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectIdentityAttributeValuesListValue in requestObject.IdentityAttributeValues)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AttributeNameAndValueMarshaller.Instance;
                    marshaller.Marshall(requestObjectIdentityAttributeValuesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSourceObjectReference())
            {
                context.Writer.WritePropertyName("SourceObjectReference");
                context.Writer.WriteObjectStart();

                var marshaller = ObjectReferenceMarshaller.Instance;
                marshaller.Marshall(requestObject.SourceObjectReference, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTargetObjectReference())
            {
                context.Writer.WritePropertyName("TargetObjectReference");
                context.Writer.WriteObjectStart();

                var marshaller = ObjectReferenceMarshaller.Instance;
                marshaller.Marshall(requestObject.TargetObjectReference, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTypedLinkFacet())
            {
                context.Writer.WritePropertyName("TypedLinkFacet");
                context.Writer.WriteObjectStart();

                var marshaller = TypedLinkSchemaAndFacetNameMarshaller.Instance;
                marshaller.Marshall(requestObject.TypedLinkFacet, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static TypedLinkSpecifierMarshaller Instance = new TypedLinkSpecifierMarshaller();

    }
}