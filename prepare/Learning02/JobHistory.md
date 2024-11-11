```mermaid
---
title: Job History
---
classDiagram
    class Job{
        string _company
        string _jobTitle
        int _startYear
        int _endYear
        Display() void
    }
    class Resume{
        string _name
        list _jobs
        Display() void
    }
```