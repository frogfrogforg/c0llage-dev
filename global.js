import { Events } from "./core/events.js"

// -- props --
const root = window.top
const keys = ["d", "b"]

// -- api --
if (root.d == null) {
  // global obj for other shared modules
  const global = {
    Events
  }

  // share it between every key
  for (const name of keys) {
    root[name] = global
  }
}

// -- "exports" --
if (window.d == null) {
  for (const name of keys) {
    Object.defineProperty(window, name, {
      configurable: true,
      get() {
        return root.d
      }
    })
  }
}
