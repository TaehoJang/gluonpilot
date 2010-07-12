﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Communication.Frames.Configuration
{
    public class AllConfig
    {
        // sensors
        public int acc_x_neutral;
        public int acc_y_neutral;
        public int acc_z_neutral;
        public int gyro_x_neutral;
        public int gyro_y_neutral;
        public int gyro_z_neutral;

        // control
        public double control_max_roll;
        public double control_max_pitch;
        public double control_aileron_differential;
        public int control_mixing;

        // gps
        public int gps_initial_baudrate;
        public int gps_operational_baudrate;

        // channels 1 - 8
        public int channel_roll;
        public int channel_pitch;
        public int channel_yaw;
        public int channel_motor;
        public int channel_ap;
        public int rc_ppm;

        // telemetry
        public int telemetry_gyroaccraw;
        public int telemetry_gyroaccproc;
        public int telemetry_ppm;
        public int telemetry_basicgps;
        public int telemetry_pressuretemp;
        public int telemetry_attitude;

        // pid
        public double pid_pitch2elevator_p;
        public double pid_pitch2elevator_i;
        public double pid_pitch2elevator_d;
        public double pid_pitch2elevator_imin;
        public double pid_pitch2elevator_imax;
        public double pid_pitch2elevator_dmin;

        public double pid_roll2aileron_p;
        public double pid_roll2aileron_i;
        public double pid_roll2aileron_d;
        public double pid_roll2aileron_imin;
        public double pid_roll2aileron_imax;
        public double pid_roll2aileron_dmin;

        public double pid_heading2roll_p;
        public double pid_heading2roll_i;
        public double pid_heading2roll_d;
        public double pid_heading2roll_imin;
        public double pid_heading2roll_imax;
        public double pid_heading2roll_dmin;

        // servo
        public bool[] servo_reverse = new bool[8];

        public int[] servo_min = new int[6];
        public int[] servo_max = new int[6];
        public int[] servo_neutral = new int[6];
    }
}
