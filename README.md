# StudyFlow AI

An autonomous AI-powered academic assistant that helps students analyze assignments, generate study plans, extract tasks, and manage academic workflows intelligently.

---

# Overview

StudyFlow AI is designed to move beyond traditional chatbot interactions by introducing an agent-based workflow system for students. The platform analyzes uploaded assignments, extracts actionable tasks, prioritizes work, and generates structured study plans automatically.

The system combines:

* AI reasoning
* task planning
* workflow automation
* backend APIs
* database integration

to create a practical academic productivity assistant.

---

# Problem Statement

Students often struggle with:

* understanding lengthy assignments
* breaking work into manageable tasks
* planning deadlines effectively
* organizing study schedules
* tracking academic progress

StudyFlow AI solves this by autonomously analyzing academic material and generating structured workflows.

---

# Features

## Assignment Upload

Users can upload:

* PDF documents
* images
* plain text assignments

---

## AI-Powered Analysis

The system uses Gemini AI to:

* analyze assignment content
* identify important topics
* extract tasks and requirements
* detect deadlines and priorities

---

## Autonomous Workflow Planning

The AI agent:

* breaks assignments into subtasks
* generates study plans
* estimates workload
* prioritizes tasks intelligently

---

## Task Management

Students can:

* track progress
* manage completed tasks
* monitor priorities
* view estimated completion timelines

---

# Architecture

```text
Frontend (React + Tailwind)
            ↓
ASP.NET Core Web API
            ↓
Agent Workflow Engine
            ↓
Gemini AI Integration
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
StudyFlowAI/
│
├── Controllers/
├── Services/
├── Repositories/
├── Agents/
├── Models/
├── DTOs/
├── Data/
├── Helpers/
├── Interfaces/
└── Program.cs
```

---

# Workflow

```text
User Uploads Assignment
            ↓
Document Analysis Agent
            ↓
Task Extraction
            ↓
Planning Agent
            ↓
Study Plan Generation
            ↓
Database Storage
            ↓
Dashboard Response
```

---

# AI Agent Responsibilities

## Document Analysis Agent

Responsible for:

* reading uploaded content
* extracting academic requirements
* identifying important information

---

## Planning Agent

Responsible for:

* generating study schedules
* creating subtasks
* prioritizing work
* estimating study time

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

## Get Assignments

```http
GET /api/assignments
```

---

## Get Tasks

```http
GET /api/tasks
```

---

## Update Task Status

```http
PUT /api/tasks/{id}
```

---

# Future Improvements

* Authentication system
* Calendar integration
* Reminder notifications
* Multi-agent collaboration
* Voice assistant support
* AI-generated summaries
* Mobile application
* Real-time progress tracking

---

# Deployment Plan

The application is deployed using:

* Vultr VPS
* Ubuntu Server
* ASP.NET Core Hosting
* Nginx Reverse Proxy

---

# Goals

The main objective of this project is to demonstrate:

* autonomous AI workflows
* practical AI integration
* intelligent task planning
* real-world productivity automation

---

# Team Vision

StudyFlow AI aims to transform how students manage academic workloads by combining artificial intelligence with structured workflow automation.

---

# License

This project is developed for educational and hackathon purposes.
