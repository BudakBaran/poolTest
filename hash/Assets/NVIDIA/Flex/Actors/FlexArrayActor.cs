﻿// This code contains NVIDIA Confidential Information and is disclosed to you
// under a form of NVIDIA software license agreement provided separately to you.
//
// Notice
// NVIDIA Corporation and its licensors retain all intellectual property and
// proprietary rights in and to this software and related documentation and
// any modifications thereto. Any use, reproduction, disclosure, or
// distribution of this software and related documentation without an express
// license agreement from NVIDIA Corporation is strictly prohibited.
//
// ALL NVIDIA DESIGN SPECIFICATIONS, CODE ARE PROVIDED "AS IS.". NVIDIA MAKES
// NO WARRANTIES, EXPRESSED, IMPLIED, STATUTORY, OR OTHERWISE WITH RESPECT TO
// THE MATERIALS, AND EXPRESSLY DISCLAIMS ALL IMPLIED WARRANTIES OF NONINFRINGEMENT,
// MERCHANTABILITY, AND FITNESS FOR A PARTICULAR PURPOSE.
//
// Information and code furnished is believed to be accurate and reliable.
// However, NVIDIA Corporation assumes no responsibility for the consequences of use of such
// information or for any infringement of patents or other rights of third parties that may
// result from its use. No license is granted by implication or otherwise under any patent
// or patent rights of NVIDIA Corporation. Details are subject to change without notice.
// This code supersedes and replaces all information previously supplied.
// NVIDIA Corporation products are not authorized for use as critical
// components in life support devices or systems without express written approval of
// NVIDIA Corporation.
//
// Copyright (c) 2018 NVIDIA Corporation. All rights reserved.

using UnityEngine;

namespace NVIDIA.Flex
{
    [ExecuteInEditMode]
    [DisallowMultipleComponent]
    [AddComponentMenu("NVIDIA/Flex/Flex Array Actor")]
    public class FlexArrayActor : FlexActor
    {
        #region Properties

        public new FlexArrayAsset asset
        {
            get { return m_asset; }
            set { m_asset = value; }
        }

        #endregion

        #region Messages

        void OnDrawGizmos()
        {
            if (m_asset && m_asset.boundaryMesh)
            {
                Gizmos.color = new Color(0, 0, 0, 0);
                Gizmos.matrix = transform.localToWorldMatrix;
                Gizmos.DrawMesh(m_asset.boundaryMesh, Vector3.zero, Quaternion.identity, m_asset.meshLocalScale);
            }
        }

        void OnDrawGizmosSelected()
        {
            if (m_asset && m_asset.boundaryMesh)
            {
              
            }
        }

        #endregion

        #region Protected

        protected override FlexAsset subclassAsset { get { return m_asset; } }

        protected override void CreateInstance()
        {
            base.CreateInstance();
        }

        protected override void DestroyInstance()
        {
            base.DestroyInstance();
        }

        protected override void ValidateFields()
        {
            base.ValidateFields();
        }

        #endregion

        #region Private

        [SerializeField]
        FlexArrayAsset m_asset;

        #endregion
    }
}
