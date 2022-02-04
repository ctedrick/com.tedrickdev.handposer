﻿using UnityEngine;

namespace TedrickDev.XRPoser
{
    [CreateAssetMenu(fileName = "Pose", menuName = "Create Pose", order = 0)]
    public class PoseData : ScriptableObject
    {
        public PoseTransform[] LeftJoints;
        public PoseTransform[] RightJoints;

        public PoseTransform LeftParentTransform;
        public PoseTransform RightParentTransform;
        
        public void SaveLeftHandData(PoseTransform[] leftData, Transform leftParent)
        {
            LeftJoints = leftData;
            LeftParentTransform = new PoseTransform {
                LocalPosition = leftParent.localPosition,
                LocalRotation = leftParent.localRotation
            };
        }
        
        public void SaveRightHandData(PoseTransform[] rightData, Transform rightParent)
        {
            RightJoints = rightData;
            RightParentTransform = new PoseTransform {
                LocalPosition = rightParent.localPosition,
                LocalRotation = rightParent.localRotation
            };
        }
    }
}