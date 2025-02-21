using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : Seek
{
    public GameObject[] path;
<<<<<<< Updated upstream

    float pathOffset;

    int currentPathIndex;

    float targetRadius = .5f;
=======
    int currTarget = 0;
    float targetRadius = 0.5f;

    int closestIndex = 0;
    float closestDistance = float.MaxValue;
>>>>>>> Stashed changes

    public override SteeringOutput getSteering()
    {
        if (target == null)
        {
<<<<<<< Updated upstream
            int nearestPathIndex = 0;
            float distanceToNearest = float.PositiveInfinity;
            for (int i = 0; i < path.Length; i++)
            {
                GameObject candidate = path[i];
                Vector3 vectorToCandidate = candidate.transform.position - character.transform.position;
                float distanceToCandidate = vectorToCandidate.magnitude;
                if (distanceToCandidate < distanceToNearest)
                {
                    nearestPathIndex = i;
                    distanceToNearest = distanceToCandidate;
                }
            }

            target = path[nearestPathIndex];
        }

        float distanceToTarget = (target.transform.position - character.transform.position).magnitude;
        if (distanceToTarget < targetRadius)
        {
            currentPathIndex++;
            if (currentPathIndex > path.Length - 1)
            {
                currentPathIndex = 0;
            }
            target = path[currentPathIndex];
=======
            for (int i = 0; i < path.Length; i++)
            {
                float distance = Vector3.Distance(character.transform.position, path[i].transform.position);
                if (distance < closestDistance)
                {
                    closestIndex = i;
                    closestDistance = distance;
                }
            }
            target = path[closestIndex];
        }

        float radDistance = Vector3.Distance(target.transform.position, character.transform.position);
        if (radDistance < targetRadius)
        {
            currTarget = (currTarget + 1) % path.Length;
            target = path[currTarget];
>>>>>>> Stashed changes
        }

        return base.getSteering();
    }
}