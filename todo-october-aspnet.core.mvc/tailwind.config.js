// tailwind.config.js
module.exports = {
    mode:"jit",
    purge: [
        './Views/**/*.{html,cshtml}',
        './wwwroot/**/*.{js,jsx,ts,tsx,vue}',
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