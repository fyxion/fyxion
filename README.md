# Fyxion
**Fyxion** is an web application framework written in F#.
Its concept is: _"Building applications like writing an story."_

Inspired by storytelling, Fyxion components are named after elements of written-ink, parchment, and structure-creating a poetic yet practical development experience.

---

## 🧬Core Features

### 💻 fyx
Command-line tool for scaffolding and managing Fyxion projects.

- Generate models, routes, and templates.
- Run development server.
- Initialize new application with 'fyx new'.

---

### 🧭 Route
Routing layer that maps URL paths to handler functions.

- Register routes using `Route.get "/path"`
- Dispatch requests with `Route.handle "/path"`

---

### 📜 Parchment
Template engine for building and rendering dynamic views.

- Supports `{{variable}}` syntax for placeholder replacement
- Planned: conditionals and loops (e.g., `{% if %}`, `{% for %}`)

---

### ✒️ Ink
ORM for defining and managing models.

- Define models by inheriting from `Ink<'T>`
- Provides `find`, `all`, `save` on in-memory backend
- Future: database integration via provider backend
