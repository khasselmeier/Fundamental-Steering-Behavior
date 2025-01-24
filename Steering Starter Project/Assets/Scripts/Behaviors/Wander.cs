using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : Seek
{
    //float wanderOffset;
    //float wanderRadius;
    float wanderRate = 3;
    float wanderOrientation = 0;
    float maxAcceleration = 10f;

    public override SteeringOutput getSteering()
    {
        SteeringOutput result = new SteeringOutput();
        wanderOrientation += Random.insideUnitCircle.x * wanderRate;
        //float targetOrientation = wanderOrientation + character.transform.eulerAngles.y; BAD
        Vector3 target = getTargetPosition(); // from seek
        //target += wanderRadius * (targetOrientation * Vector3.one); BAD BAD
        //result.linear = maxAcceleration * character.transform.position; MEAN
        result.linear = wanderOrientation * character.transform.position;
        result.linear.Normalize();
        result.linear *= maxAcceleration;
        result.angular = 0;
        return result;
    }
}