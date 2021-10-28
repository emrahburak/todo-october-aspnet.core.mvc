// tailwind.config.js
module.exports = {
    mode:"jit",
    purge: [
        './Views/**/*.{html,cshtml}',
        './Pages/**/*.cshtml',
    ],
  darkMode: false, // or 'media' or 'class'
  theme: {
    extend: {},
  },
  variants: {
    extend: {},
  },
  plugins: [],
}