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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAutoScalingGroup operation.
    /// Updates the configuration for the specified Auto Scaling group.
    /// 
    ///  
    /// <para>
    /// To update an Auto Scaling group, specify the name of the group and the parameter that
    /// you want to change. Any parameters that you don't specify are not changed by this
    /// update request. The new settings take effect on any scaling activities after this
    /// call returns. Scaling activities that are currently in progress aren't affected.
    /// </para>
    ///  
    /// <para>
    /// If you associate a new launch configuration or template with an Auto Scaling group,
    /// all new instances will get the updated configuration, but existing instances continue
    /// to run with the configuration that they were originally launched with. When you update
    /// a group to specify a mixed instances policy instead of a launch configuration or template,
    /// existing instances may be replaced to match the new purchasing options that you specified
    /// in the policy. For example, if the group currently has 100% On-Demand capacity and
    /// the policy specifies 50% Spot capacity, this means that half of your instances will
    /// be gradually terminated and relaunched as Spot Instances. When replacing instances,
    /// Amazon EC2 Auto Scaling launches new instances before terminating the old ones, so
    /// that updating your group does not compromise the performance or availability of your
    /// application.
    /// </para>
    ///  
    /// <para>
    /// Note the following about changing <code>DesiredCapacity</code>, <code>MaxSize</code>,
    /// or <code>MinSize</code>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If a scale-in event occurs as a result of a new <code>DesiredCapacity</code> value
    /// that is lower than the current size of the group, the Auto Scaling group uses its
    /// termination policy to determine which instances to terminate.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you specify a new value for <code>MinSize</code> without specifying a value for
    /// <code>DesiredCapacity</code>, and the new <code>MinSize</code> is larger than the
    /// current size of the group, this sets the group's <code>DesiredCapacity</code> to the
    /// new <code>MinSize</code> value.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you specify a new value for <code>MaxSize</code> without specifying a value for
    /// <code>DesiredCapacity</code>, and the new <code>MaxSize</code> is smaller than the
    /// current size of the group, this sets the group's <code>DesiredCapacity</code> to the
    /// new <code>MaxSize</code> value.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To see which parameters have been set, use <a>DescribeAutoScalingGroups</a>. You can
    /// also view the scaling policies for an Auto Scaling group using <a>DescribePolicies</a>.
    /// If the group has scaling policies, you can update them using <a>PutScalingPolicy</a>.
    /// </para>
    /// </summary>
    public partial class UpdateAutoScalingGroupRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private List<string> _availabilityZones = new List<string>();
        private int? _defaultCooldown;
        private int? _desiredCapacity;
        private int? _healthCheckGracePeriod;
        private string _healthCheckType;
        private string _launchConfigurationName;
        private LaunchTemplateSpecification _launchTemplate;
        private int? _maxSize;
        private int? _minSize;
        private MixedInstancesPolicy _mixedInstancesPolicy;
        private bool? _newInstancesProtectedFromScaleIn;
        private string _placementGroup;
        private string _serviceLinkedRoleARN;
        private List<string> _terminationPolicies = new List<string>();
        private string _vpcZoneIdentifier;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string AutoScalingGroupName
        {
            get { return this._autoScalingGroupName; }
            set { this._autoScalingGroupName = value; }
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this._autoScalingGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// One or more Availability Zones for the group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && this._availabilityZones.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DefaultCooldown. 
        /// <para>
        /// The amount of time, in seconds, after a scaling activity completes before another
        /// scaling activity can start. The default value is <code>300</code>. This cooldown period
        /// is not used when a scaling-specific cooldown is specified.
        /// </para>
        ///  
        /// <para>
        /// Cooldown periods are not supported for target tracking scaling policies, step scaling
        /// policies, or scheduled scaling. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/Cooldown.html">Scaling
        /// Cooldowns</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public int DefaultCooldown
        {
            get { return this._defaultCooldown.GetValueOrDefault(); }
            set { this._defaultCooldown = value; }
        }

        // Check to see if DefaultCooldown property is set
        internal bool IsSetDefaultCooldown()
        {
            return this._defaultCooldown.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DesiredCapacity. 
        /// <para>
        /// The number of EC2 instances that should be running in the Auto Scaling group. This
        /// number must be greater than or equal to the minimum size of the group and less than
        /// or equal to the maximum size of the group.
        /// </para>
        /// </summary>
        public int DesiredCapacity
        {
            get { return this._desiredCapacity.GetValueOrDefault(); }
            set { this._desiredCapacity = value; }
        }

        // Check to see if DesiredCapacity property is set
        internal bool IsSetDesiredCapacity()
        {
            return this._desiredCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HealthCheckGracePeriod. 
        /// <para>
        /// The amount of time, in seconds, that Amazon EC2 Auto Scaling waits before checking
        /// the health status of an EC2 instance that has come into service. The default value
        /// is <code>0</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/healthcheck.html">Health
        /// Checks for Auto Scaling Instances</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Conditional: This parameter is required if you are adding an <code>ELB</code> health
        /// check.
        /// </para>
        /// </summary>
        public int HealthCheckGracePeriod
        {
            get { return this._healthCheckGracePeriod.GetValueOrDefault(); }
            set { this._healthCheckGracePeriod = value; }
        }

        // Check to see if HealthCheckGracePeriod property is set
        internal bool IsSetHealthCheckGracePeriod()
        {
            return this._healthCheckGracePeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HealthCheckType. 
        /// <para>
        /// The service to use for the health checks. The valid values are <code>EC2</code> and
        /// <code>ELB</code>. If you configure an Auto Scaling group to use ELB health checks,
        /// it considers the instance unhealthy if it fails either the EC2 status checks or the
        /// load balancer health checks.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string HealthCheckType
        {
            get { return this._healthCheckType; }
            set { this._healthCheckType = value; }
        }

        // Check to see if HealthCheckType property is set
        internal bool IsSetHealthCheckType()
        {
            return this._healthCheckType != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchConfigurationName. 
        /// <para>
        /// The name of the launch configuration. If you specify <code>LaunchConfigurationName</code>
        /// in your update request, you can't specify <code>LaunchTemplate</code> or <code>MixedInstancesPolicy</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// To update an Auto Scaling group with a launch configuration with <code>InstanceMonitoring</code>
        /// set to <code>false</code>, you must first disable the collection of group metrics.
        /// Otherwise, you get an error. If you have previously enabled the collection of group
        /// metrics, you can disable it using <a>DisableMetricsCollection</a>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string LaunchConfigurationName
        {
            get { return this._launchConfigurationName; }
            set { this._launchConfigurationName = value; }
        }

        // Check to see if LaunchConfigurationName property is set
        internal bool IsSetLaunchConfigurationName()
        {
            return this._launchConfigurationName != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchTemplate. 
        /// <para>
        /// The launch template and version to use to specify the updates. If you specify <code>LaunchTemplate</code>
        /// in your update request, you can't specify <code>LaunchConfigurationName</code> or
        /// <code>MixedInstancesPolicy</code>.
        /// </para>
        /// </summary>
        public LaunchTemplateSpecification LaunchTemplate
        {
            get { return this._launchTemplate; }
            set { this._launchTemplate = value; }
        }

        // Check to see if LaunchTemplate property is set
        internal bool IsSetLaunchTemplate()
        {
            return this._launchTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property MaxSize. 
        /// <para>
        /// The maximum size of the Auto Scaling group.
        /// </para>
        /// </summary>
        public int MaxSize
        {
            get { return this._maxSize.GetValueOrDefault(); }
            set { this._maxSize = value; }
        }

        // Check to see if MaxSize property is set
        internal bool IsSetMaxSize()
        {
            return this._maxSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinSize. 
        /// <para>
        /// The minimum size of the Auto Scaling group.
        /// </para>
        /// </summary>
        public int MinSize
        {
            get { return this._minSize.GetValueOrDefault(); }
            set { this._minSize = value; }
        }

        // Check to see if MinSize property is set
        internal bool IsSetMinSize()
        {
            return this._minSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MixedInstancesPolicy. 
        /// <para>
        /// An embedded object that specifies a mixed instances policy.
        /// </para>
        ///  
        /// <para>
        /// In your call to <code>UpdateAutoScalingGroup</code>, you can make changes to the policy
        /// that is specified. All optional parameters are left unchanged if not specified.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-purchase-options.html">Auto
        /// Scaling Groups with Multiple Instance Types and Purchase Options</a> in the <i>Amazon
        /// EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public MixedInstancesPolicy MixedInstancesPolicy
        {
            get { return this._mixedInstancesPolicy; }
            set { this._mixedInstancesPolicy = value; }
        }

        // Check to see if MixedInstancesPolicy property is set
        internal bool IsSetMixedInstancesPolicy()
        {
            return this._mixedInstancesPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property NewInstancesProtectedFromScaleIn. 
        /// <para>
        /// Indicates whether newly launched instances are protected from termination by Amazon
        /// EC2 Auto Scaling when scaling in.
        /// </para>
        ///  
        /// <para>
        /// For more information about preventing instances from terminating on scale in, see
        /// <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-instance-termination.html#instance-protection">Instance
        /// Protection</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public bool NewInstancesProtectedFromScaleIn
        {
            get { return this._newInstancesProtectedFromScaleIn.GetValueOrDefault(); }
            set { this._newInstancesProtectedFromScaleIn = value; }
        }

        // Check to see if NewInstancesProtectedFromScaleIn property is set
        internal bool IsSetNewInstancesProtectedFromScaleIn()
        {
            return this._newInstancesProtectedFromScaleIn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PlacementGroup. 
        /// <para>
        /// The name of the placement group into which to launch your instances, if any. A placement
        /// group is a logical grouping of instances within a single Availability Zone. You cannot
        /// specify multiple Availability Zones and a placement group. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html">Placement
        /// Groups</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string PlacementGroup
        {
            get { return this._placementGroup; }
            set { this._placementGroup = value; }
        }

        // Check to see if PlacementGroup property is set
        internal bool IsSetPlacementGroup()
        {
            return this._placementGroup != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceLinkedRoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service-linked role that the Auto Scaling group
        /// uses to call other AWS services on your behalf. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-service-linked-role.html">Service-Linked
        /// Roles</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string ServiceLinkedRoleARN
        {
            get { return this._serviceLinkedRoleARN; }
            set { this._serviceLinkedRoleARN = value; }
        }

        // Check to see if ServiceLinkedRoleARN property is set
        internal bool IsSetServiceLinkedRoleARN()
        {
            return this._serviceLinkedRoleARN != null;
        }

        /// <summary>
        /// Gets and sets the property TerminationPolicies. 
        /// <para>
        /// A standalone termination policy or a list of termination policies used to select the
        /// instance to terminate. The policies are executed in the order that they are listed.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-instance-termination.html">Controlling
        /// Which Instances Auto Scaling Terminates During Scale In</a> in the <i>Amazon EC2 Auto
        /// Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public List<string> TerminationPolicies
        {
            get { return this._terminationPolicies; }
            set { this._terminationPolicies = value; }
        }

        // Check to see if TerminationPolicies property is set
        internal bool IsSetTerminationPolicies()
        {
            return this._terminationPolicies != null && this._terminationPolicies.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VPCZoneIdentifier. 
        /// <para>
        /// A comma-separated list of subnet IDs for virtual private cloud (VPC).
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>VPCZoneIdentifier</code> with <code>AvailabilityZones</code>,
        /// the subnets that you specify for this parameter must reside in those Availability
        /// Zones.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2047)]
        public string VPCZoneIdentifier
        {
            get { return this._vpcZoneIdentifier; }
            set { this._vpcZoneIdentifier = value; }
        }

        // Check to see if VPCZoneIdentifier property is set
        internal bool IsSetVPCZoneIdentifier()
        {
            return this._vpcZoneIdentifier != null;
        }

    }
}