# Cognivex AI

### Autonomous Academic Workflow Intelligence Platform

---

# Overview

Cognivex AI is an agent-based academic productivity platform designed to help students manage assignments, organize study workflows, and automate academic planning using artificial intelligence.

The system analyzes uploaded academic material, extracts actionable tasks, prioritizes workloads, and generates structured study plans through autonomous AI workflows.

Unlike traditional chatbots, Cognivex AI focuses on intelligent task orchestration, workflow automation, and multi-step academic assistance.

---

# Problem Statement

Students frequently face challenges such as:

* understanding complex assignments
* organizing study schedules
* tracking deadlines
* prioritizing academic tasks
* managing workload efficiently

Cognivex AI addresses these challenges by providing an intelligent workflow-driven assistant capable of planning and managing academic activities autonomously.

---

# Core Features

## Intelligent Assignment Analysis

Users can upload:

* PDF documents
* images
* plain text assignments

The AI system extracts:

* important requirements
* deadlines
* topics
* actionable tasks

---

## Autonomous Workflow Planning

The platform automatically:

* divides assignments into subtasks
* generates study roadmaps
* prioritizes tasks
* estimates workload and completion time

---

## AI-Powered Academic Assistance

Cognivex AI uses Gemini AI models to:

* analyze educational content
* summarize material
* assist in task planning
* support intelligent reasoning workflows

---

## Task Management Dashboard

Users can:

* track assignment progress
* manage task completion
* monitor priorities
* visualize academic workflow status

---

# System Architecture

```text
Frontend (React + Tailwind CSS)
                ↓
ASP.NET Core Web API
                ↓
Agent Workflow Engine
                ↓
Gemini AI Integration Layer
                ↓
SQL Server Database
```

---

# Technology Stack

## Frontend

* React
* Tailwind CSS

## Backend

* ASP.NET Core Web API
* C#

## Database

* SQL Server

## AI Integration

* Google Gemini API

## Deployment

* Vultr VPS
* Ubuntu Server
* Nginx Reverse Proxy

---

# Project Structure

```text
CognivexAI/
│
├── Controllers/
├── Services/
├── Repositories/
├── Agents/
├── Models/
├── DTOs/
├── Data/
├── Interfaces/
├── Helpers/
└── Program.cs
```

---

# Workflow Pipeline

```text
Assignment Upload
        ↓
Document Analysis Agent
        ↓
Task Extraction Engine
        ↓
Planning & Prioritization Agent
        ↓
Study Workflow Generation
        ↓
Database Storage
        ↓
Frontend Dashboard Response
```

---

# AI Agent Modules

## Document Analysis Agent

Responsible for:

* extracting assignment content
* identifying academic requirements
* analyzing uploaded material

---

## Planning Agent

Responsible for:

* generating study schedules
* estimating effort
* prioritizing subtasks
* workflow orchestration

---

# Database Design

## Assignments Table

```sql
AssignmentId
Title
Description
CreatedAt
```

---

## Tasks Table

```sql
TaskItemId
AssignmentId
TaskTitle
Priority
Status
EstimatedHours
```

---

# API Endpoints

## Upload Assignment

```http
POST /api/assignments/upload
```

---

## Retrieve Assignments

```http
GET /api/assignments
```

---

## Retrieve Tasks

```http
GET /api/tasks
```

---

## Update Task Status

```http
PUT /api/tasks/{id}
```

---

# Future Enhancements

* Multi-agent collaboration
* Calendar synchronization
* Smart reminder system
* AI-generated summaries
* Real-time notifications
* Mobile application support
* Voice-based interaction
* Learning analytics dashboard

---

# Objective

The primary goal of Cognivex AI is to demonstrate:

* autonomous AI workflows
* intelligent academic orchestration
* practical AI integration
* workflow-driven productivity systems

---

# Team Vision

Cognivex AI aims to redefine academic productivity through intelligent workflow automation and agentic AI systems capable of assisting students in real-world educational environments.

---

# License

Developed for educational and hackathon purposes.
