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
 * Do not modify this file. This file is generated from the mq-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MQ.Model
{
    /// <summary>
    /// Returns information about all configurations.
    /// </summary>
    public partial class Configuration
    {
        private string _arn;
        private string _description;
        private EngineType _engineType;
        private string _engineVersion;
        private string _id;
        private ConfigurationRevision _latestRevision;
        private string _name;

        /// <summary>
        /// Gets and sets the property Arn. Required. The ARN of the configuration.
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Description. Required. The description of the configuration.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EngineType. Required. The type of broker engine. Note:
        /// Currently, Amazon MQ supports only ACTIVEMQ.
        /// </summary>
        public EngineType EngineType
        {
            get { return this._engineType; }
            set { this._engineType = value; }
        }

        // Check to see if EngineType property is set
        internal bool IsSetEngineType()
        {
            return this._engineType != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. Required. The version of the broker engine.
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Id. Required. The unique ID that Amazon MQ generates for
        /// the configuration.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LatestRevision. Required. The latest revision of the configuration.
        /// </summary>
        public ConfigurationRevision LatestRevision
        {
            get { return this._latestRevision; }
            set { this._latestRevision = value; }
        }

        // Check to see if LatestRevision property is set
        internal bool IsSetLatestRevision()
        {
            return this._latestRevision != null;
        }

        /// <summary>
        /// Gets and sets the property Name. Required. The name of the configuration. This value
        /// can contain only alphanumeric characters, dashes, periods, underscores, and tildes
        /// (- . _ ~). This value must be 1-150 characters long.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}